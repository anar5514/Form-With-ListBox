using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormWithListBox
{
    public partial class FormWithListBox : System.Windows.Forms.Form
    {
        public string DefaultNameText { get; set; }
        public string DefaultSurnameText { get; set; }
        public string DefaultEmailText { get; set; }
        public string DefaultPhoneText { get; set; }
        public string DefaultdateOfBirthText { get; set; }
        public string DefaultFilenameText { get; set; }

        public FormWithListBox()
        {
            InitializeComponent();
        }

        private void FormWithListBox_Load(object sender, EventArgs e)
        {
            listbox.DisplayMember = "Name";

        }

        private void txtboxName_Enter(object sender, EventArgs e)
        {
            if (txtboxName.ForeColor == Color.CadetBlue)
            {
                DefaultNameText = txtboxName.Text;
                txtboxName.TextChanged += Txtbox_TextChanged;
                txtboxName.Text = String.Empty;
            }
        }

        private void Txtbox_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = Color.Black;
        }

        private void txtboxName_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == String.Empty)
            {
                (sender as TextBox).Text = DefaultNameText;
                (sender as TextBox).ForeColor = Color.CadetBlue;
            }
        }

        private void txtboxSurname_Enter(object sender, EventArgs e)
        {
            if (txtboxSurname.ForeColor == Color.CadetBlue)
            {
                DefaultSurnameText = txtboxSurname.Text;
                txtboxSurname.TextChanged += Txtbox_TextChanged;
                txtboxSurname.Text = String.Empty;
            }
        }

        private void txtboxSurname_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == String.Empty)
            {
                (sender as TextBox).Text = DefaultSurnameText;
                (sender as TextBox).ForeColor = Color.CadetBlue;
            }
        }

        private void txtboxEmail_Enter(object sender, EventArgs e)
        {
            if (txtboxEmail.ForeColor == Color.CadetBlue)
            {
                DefaultEmailText = txtboxEmail.Text;
                txtboxEmail.TextChanged += Txtbox_TextChanged;
                txtboxEmail.Text = String.Empty;
            }
        }

        private void txtboxEmail_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == String.Empty)
            {
                (sender as TextBox).Text = DefaultEmailText;
                (sender as TextBox).ForeColor = Color.CadetBlue;
            }
        }

        private void txtboxPhone_Enter(object sender, EventArgs e)
        {
            if (txtboxPhone.ForeColor == Color.CadetBlue)
            {
                DefaultPhoneText = txtboxPhone.Text;
                txtboxPhone.TextChanged += Txtbox_TextChanged;
                txtboxPhone.Text = String.Empty;
            }
        }

        private void txtboxPhone_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == String.Empty)
            {
                (sender as TextBox).Text = DefaultPhoneText;
                (sender as TextBox).ForeColor = Color.CadetBlue;
            }
        }

        private void txtboxDateofbirth_Enter(object sender, EventArgs e)
        {
            if (txtboxDateofbirth.ForeColor == Color.CadetBlue)
            {
                DefaultdateOfBirthText = txtboxDateofbirth.Text;
                txtboxDateofbirth.TextChanged += Txtbox_TextChanged;
                txtboxDateofbirth.Text = String.Empty;
            }
        }

        private void txtboxDateofbirth_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == String.Empty)
            {
                (sender as TextBox).Text = DefaultdateOfBirthText;
                (sender as TextBox).ForeColor = Color.CadetBlue;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                Name = txtboxName.Text,
                Surname = txtboxSurname.Text,
                Email = txtboxEmail.Text,
                Phone = txtboxPhone.Text,
                Dateofbirth = txtboxDateofbirth.Text
            };

            listbox.Items.Add(person);

            txtboxName.Text = DefaultNameText;
            txtboxSurname.Text = DefaultSurnameText;
            txtboxEmail.Text = DefaultEmailText;
            txtboxPhone.Text = DefaultPhoneText;
            txtboxDateofbirth.Text = DefaultdateOfBirthText;

            foreach (var item in grpbox.Controls.OfType<TextBox>())
            {
                item.ForeColor = Color.CadetBlue;
            }
        }

        private void txtboxFilename_TextChanged(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = Color.Black;
        }

        private void txtboxFilename_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).ForeColor == Color.CadetBlue)
            {
                DefaultFilenameText = (sender as TextBox).Text;
                (sender as TextBox).TextChanged += txtboxFilename_TextChanged;
                (sender as TextBox).Text = String.Empty;
            }
        }

        private void txtboxFilename_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == String.Empty)
            {
                (sender as TextBox).Text = DefaultFilenameText;
                (sender as TextBox).ForeColor = Color.CadetBlue;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var str = JsonConvert.SerializeObject(listbox.Items);

            File.WriteAllText(txtboxFilename.Text + ".json", str);

            txtboxFilename.Text = DefaultFilenameText;
            txtboxFilename.ForeColor = Color.CadetBlue;
            listbox.Items.Clear();          
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var str = File.ReadAllText(txtboxFilename.Text + ".json");
            var persons = JsonConvert.DeserializeObject<Person[]>(str);

            listbox.Items.Clear();
            listbox.Items.AddRange(persons);        
        }

        private void btnChange_MouseHover(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Azure;
        }

        private void btnChange_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Azure;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var senderListBox = sender as ListBox;
            var person = senderListBox.Items[senderListBox.SelectedIndex] as Person;

            txtboxName.Text = person.Name;
            txtboxSurname.Text = person.Surname;
            txtboxEmail.Text = person.Email;
            txtboxPhone.Text = person.Phone;
            txtboxDateofbirth.Text = person.Dateofbirth;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var person = listbox.Items[listbox.SelectedIndex] as Person;

            person.Name = txtboxName.Text;
            person.Surname = txtboxSurname.Text;
            person.Email = txtboxEmail.Text;
            person.Phone = txtboxPhone.Text;
            person.Dateofbirth = txtboxDateofbirth.Text;

            txtboxName.Text = DefaultNameText;
            txtboxSurname.Text = DefaultSurnameText;
            txtboxEmail.Text = DefaultEmailText;
            txtboxPhone.Text = DefaultPhoneText;
            txtboxDateofbirth.Text = DefaultdateOfBirthText;

            foreach (var item in grpbox.Controls.OfType<TextBox>())
            {
                item.ForeColor = Color.CadetBlue;
            }
        }
    }
}
