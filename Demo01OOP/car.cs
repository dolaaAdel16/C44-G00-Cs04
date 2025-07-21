using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01OOP
{
	internal class car
	{
		#region Attributes
		private int id;
		private int speed;
		private string model;
		#endregion

		#region Properties
		public string Model
		{
			get { return model; }
			set { model = value; }
		}


		public int Speed
		{
			get { return speed; }
			set { speed = value; }
		}


		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		#endregion

		public car(int id, int speed, string model)
		{
			Id = id;
			Speed = speed;
			Model = model;
        }
        public override string ToString()
		{
			return $"id : {Id} , Speed : {Speed} , Model : {Model}";
        }




	}
}
