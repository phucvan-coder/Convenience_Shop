using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProJect.Object
{
    public class StaffInfo
    {
        private int id;
        private string name;
        private string dateOfBirth;
        private string gender;
        private string email;
        private string phone;
        private string address;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
