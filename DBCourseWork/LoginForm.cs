﻿using System;
using System.Linq;
using System.Windows.Forms;
using DBCourseWork.ReDesign;

namespace DBCourseWork
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var login = logintxt.Text;
                var pass = passtxt.Text;
                var context = new ApplicationDbContext();
                var user = context.UserRoles.FirstOrDefault(roles => roles.Login == login && roles.Password == pass);
                if (user == null)
                    throw new Exception("Такого користувача не існує!");
                if (user.Role == "admin" || user.Role == "operator")
                {
                    if (user.Role == "admin")
                    {
                        var form =
                            new MainAdminForm(
                                new ApplicationDbContext(Utilities.ConnectionStringBuilder("admin", "admin")), user);
                        Hide();
                        form.Closed += (s, args) => Close();
                        form.Show();
                    }
                    if (user.Role == "operator")
                    {
                        var form =
                            new MainOperatorForm(
                                new ApplicationDbContext(Utilities.ConnectionStringBuilder("operator", "operator")), user);
                        Hide();
                        form.Closed += (s, args) => Close();
                        form.Show();
                    }
                }
                else
                {
                    throw new Exception("The user role is wrong!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    @"Помилка під час підключення! Перевірте свої логін та пароль або ж зв'яжіться з адміністратором.");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}