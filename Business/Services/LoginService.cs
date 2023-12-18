﻿using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using _420DA3_07451_Projet_Initial.Presentation;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_07451_Projet_Initial.Business.Services;
public class LoginService : AbstractLoginService {
    private LoginForm LoginForm { get; set; }
    private RoleSelectionForm RoleSelectionForm { get; set; }


    private AbstractFacade ParentFacade { get; set; }
    public UserDTO? LoggedInUser { get; protected set; }
    public RoleDTO? LoggedInUserRole { get; protected set; }

    [Obsolete("Fake constructor for appl start only. DO NOT USE.", false)]
    public LoginService() { }

    public LoginService(AbstractFacade parentFacade) {
        parentFacade.RegisterDependent(this);
        this.ParentFacade = parentFacade;
        this.LoginForm = new LoginForm(this);
        this.RoleSelectionForm = new RoleSelectionForm();
    }


    public UserDTO RequireLoggedInUser() {
        if (this.LoggedInUser == null) {
            // Pas d'utilisateur déjà connecté: forcer la connexion

            DialogResult loginResult = this.LoginForm.ShowDialog();
            if (loginResult == DialogResult.OK) {
                // Le login form devrait avoir forcé la connexion et setté l'utilisateur dans ce service

                return this.LoggedInUser ?? throw new Exception("Something went wrong, le login form devrait avoir forcé la connexion et setté l'utilisateur.");

            } else {
                // Utilisateur à annulé le processus de connexion. On ne peut continuer.
                // terminer l'application après un message.
                MessageBox.Show("Cette application requiert d'être connecté pour poursuivre. L'application va se terminer.");
                this.ParentFacade.Shutdown();

                // ligne inutile qui ne sera jamais exécutée mais qui stoppe VS de rapporter une erreur
                return this.LoggedInUser;
            }
        } else {
            // utilisateur déjà connecté, le retourner
            return this.LoggedInUser;
        }
    }

    public void AttemptLogin(string username, string password) {
        UserDTO user = this.ParentFacade.GetService<UserService>().FindUserByUsername(username) ?? throw new Exception("Nom d'utilisateur invalide.").;
        this.LoggedInUser = 
            !CryptographyService.VerifyPassword(password, user.Password) 
                ? throw new Exception("Mot de passe invalide.") 
                : user;
    }

    public override UserDTO GetLoggedInUser() {
        return this.RequireLoggedInUser();
    }

    public RoleDTO GetLoggedInUserRole() {
        if (this.LoggedInUserRole == null || this.LoggedInUser == null) {
            UserDTO loggedInUser = this.RequireLoggedInUser();
            this.LoggedInUserRole = loggedInUser.Roles.Count > 1
                ? this.RoleSelectionForm.ShowForUser(loggedInUser)
                : loggedInUser.Roles.Count <= 0
                    ? throw new Exception("L'utilisateur connecté n'a aucun de rôle associé.")
                    : loggedInUser.Roles.First();
        }
        return this.LoggedInUserRole;
    }


    public override void Shutdown() {
        this.LoggedInUser = null;
        if (!this.RoleSelectionForm.IsDisposed) {
            this.RoleSelectionForm.Dispose();
        }
        if (!this.LoginForm.IsDisposed) {
            this.LoginForm.Dispose();
        }
    }
}