using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_OOP
{
    class Iron
    {
        string _mark;
        int _temp;
        DateTime _date;
        bool _isSteam;
        bool _isOn;



        public Iron(string mark,int temp,DateTime date)
        {
            _mark = mark;
            _temp = temp;
            _date = date;
        }

        public Iron()
        {
            _mark = "Scarlett";
            _temp = 150;
            _isOn = true;
            _isSteam = true;
            _date = new DateTime(2020, 05, 03);

        }

        public void SetPower(string onPower)
        {
            if (onPower == "On")
                _isOn = true;
            else _isOn = false;
        }
              

        public void SetSteam(string action)
        {
            if (action == "Yes")
                _isSteam = true;
            else _isSteam = false;
        }
        public void SetTemp()
        {
            _temp += 20;
        }

        public int GetTemp()
        {
            return _temp;
        }

        public void Print()
        {
            Console.WriteLine($"Now you use {_mark}  with temp {_temp}" +
                $".Buying date:{_date.ToShortDateString()}." +
                $"Condition:{(_isOn==true?"On":"Off")} and steam :{(_isSteam == true ? "On" : "Off")}");
        }
    }
}
