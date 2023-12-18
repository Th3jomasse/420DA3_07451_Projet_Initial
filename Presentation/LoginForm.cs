using _420DA3_07451_Projet_Initial.Business.Abstracts;
using _420DA3_07451_Projet_Initial.Business.Services;
using _420DA3_07451_Projet_Initial.DataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_07451_Projet_Initial.Presentation;
public partial class LoginForm : Form {

    private readonly UserService service;
    private readonly AbstractFacade facade;

    public LoginForm(AbstractFacade facade) {

        this.facade = facade;
        this.service = facade.GetService<UserService>();
        this.InitializeComponent();

    }

    private void label4_Click(object sender, EventArgs e) {

    }

    private void textBoxUserName_TextChanged(object sender, EventArgs e) {

    }

    private void textBoxPassword_TextChanged(object sender, EventArgs e) {

    }

    private void buttonLogin_Click(object sender, EventArgs e) {
        string username = this.textBoxUserName.Text;
        string password = this.textBoxPassword.Text;
        UserDTO? user = this.service.FindUserByUsername(username);
        if (user != null) {
            if (user.Password == password) {
                this.CurrentUser = user;
                this.OpenFormBasedOnRole(user.Roles);
                this.Close();
            } else {
                MessageBox.Show("Invalid password");
            }
        } else {
            MessageBox.Show("Invalid username");
        }
    }

    private void OpenFormBasedOnRole(List<RoleDTO> roles) {
        if (roles.Count > 0) {
            string roleName = roles[0].RoleName;
            switch (roleName) {
                case "Admin":
                    this.UserManagementForm();
                    break;
                case "Manager":
                    this.RoleManagementForm();
                    break;
                case "Bureau":
                    this.ProduitsmanagementForm();
                    break;
                case "Entrepot":
                    this.EntrepotManagementForm();
                    break;
                case "Secretaire":
                    this.ClientManagementForm();
                    break;
                default:
                    MessageBox.Show("Invalid role.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        } else {
            MessageBox.Show("Role Invalide","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void linkLabelForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

    }
}
