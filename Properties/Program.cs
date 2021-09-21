using System;

namespace Properties
{
    class Program
    {
        private  Student std1 { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
	        PropertyDemo property = new PropertyDemo();
            int a= property.GetId();
            Console.WriteLine(property.GetId());
            property.SetId(5);
            Console.WriteLine(property.GetId());

            Console.WriteLine(property.Id);
            property.Id = 10;
            Console.WriteLine(property.Id);

            Console.WriteLine(property.ID);
            property.ID = 15;
            Console.WriteLine(property.ID);

	
        }
    }
    class Student
    {

        public int  StudentId { get; set; }

        private  int _name;
        public int GetName()
        {
            return this._name;
        }
        public void SetName(int val)
        {
            this._name = val;
        }

        public int Name {
            get
            {
                if(this._name < 10)
                {
                    return this._name;
                }
                else
                {
                    return 0;
                }
                
            }
            set {
                if(value > 18)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("You do not have eligibility.");
                }
                
            } 
        }

        public virtual int Id { get; set; }


    }
    class tenthClass : Student
    {
        public override int Id { get => base.Id; set
            {
              value =  value > 5000 ? base.Id = value : base.Id = 0;
            }
        }
    }

    class PropertyDemo
    {
        private int _id = 0;
        public int GetId()
        {
            return _id;
        }
        public void SetId(int value)
        {
            _id = value;      
        }

        public int Id {
            get
            {
                if(_id> 0)
                {
                    return _id;
                }
                else
                {
                    return -1;
                }
                
            }
            set
            {
                if(value > 5)
                {
                    _id = value;
                }
                
            }
        }

        public int ID { get; set; }

    }

}
