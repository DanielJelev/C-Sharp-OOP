using System;

    class Battery
    {

        public Battery (string type,double life)
        {
            this.Life = life;
            this.Type = type;
        }
        public string Type{ get; set; }
        public double Life { get; set; }
        
    }
