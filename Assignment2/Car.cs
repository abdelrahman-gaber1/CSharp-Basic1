using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Car
    {
		private int id;
		private string model;
		private double speed;

		public Car (int _id, string _model , double _speed)
		{
			id = _id;
			model = _model;
			speed = _speed;
		}
        public Car(int _id, string _model) :this(_id , _model, 180)
        {
            id = _id;
            model = _model;
            speed = 180;
        }
        public Car(int _id) : this(_id, "Marcedes")
        {
            id = _id;
            model = "Marcedes";
            speed = 180;
        }

        public double Speed
		{
			get { return speed; }
			set { speed = value; }
		}

		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public int ID
		{
			get { return id; }
			set { id = value; }
		}

        public override string ToString()
        {
			return $"{id} ,  {speed}  ,   {model}";
        }
    }
}
