using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class Demo
    {
        private int _myNumber;
        private int _myHeight;
        private string? _myPlants;

        public int MyNumber { get =>  _myNumber ; set => _myNumber=value; }

        public int MyHeight { get => _myHeight ; set => _myHeight=value; }

        public string MyPlants { get; set; } = "Not enough";

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }





    }
}
