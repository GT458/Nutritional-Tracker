using System;
using System.Collections.Generic;
using System.Text;

namespace NewWindowsFormsApp
{
    class Person
    {
        private string name;
        private int uid;
        private int age;
        private int weight;
        private int height;
        private int activity;
        private int gender;
        public Person()
        {

        }

        public Person(string inName, int inUID, int inAge, int inWeight, int inHeight, int inActivity, int inGender)
        {
            this.name = inName;
            this.age = inAge;
            this.uid = inUID;
            this.weight = inWeight;
            this.height = inHeight;
            this.activity = inActivity;
            this.gender = inGender;
        }

        public int getHeight()
        {
            return this.height;
        }

        public int getAge()
        {
            return age;
        }

        public int getGender()
        {
            return gender;
        }

        public string getName()
        {
            return name;
        
        }

        public int getWeight()
        {
            return weight;
        }

        public int getUID()
        {
            return uid;
        }

        public int getActivity()
        {
            return activity;
        }

        public void setAge(int inAge)
        {
            this.age = inAge;
        }

        public void setWeight(int inWeight)
        {
            this.weight = inWeight;
        }

        public void setHeight(int inHeight)
        {
            this.height = inHeight;
        }

        public void setActivity(int inActivity)
        {
            this.activity = inActivity;
        }
    }
}
