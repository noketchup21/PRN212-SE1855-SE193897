using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
        #region Nhom constructor
    public class Employee
    {
        private int _id;
        private string _name;
        private string _email;
        private string _phone;
        private string _id_card;

        public Employee()
        {
            this._id = 1;
            Id_card = "123456789";
            this._name = "Nguyen Van A";
        }

        public Employee(int _id, string _name, string _email, string _phone, string _id_card)
        {
            this._id = _id;
            this._name = _name;
            this._email = _email;
            this._phone = _phone;
            this._id_card = _id_card;
        }
        #endregion
        #region Nhom properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Id_card
        {
            get { return _id_card; }
            set { _id_card = value; }
        }
        #endregion
        #region Nhom method
        public void PrintInfo()
        {
            String msg = $"{Id}\t{Id_card}\t{Name}\t{Email}\t{Phone}";
            Console.WriteLine(msg);
        }
        public override string ToString()
        {
            String msg = $"{Id}\t{Id_card}\t{Name}\t{Email}\t{Phone}";
            return msg;
        }

    }
    #endregion
}
