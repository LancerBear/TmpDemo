using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TmpDemo
{
    class DataEntity
    {
        private int id = 0;
        private float temperature = 0;
        private int valid = 0;
        private string devID = null;
        private string addTime = null;
        public bool shown = true;



        public int getID()
        {
            return this.id;
        }

        public float getTemperature()
        {
            return this.temperature;
        }

        public string getDevID()
        {
            return this.devID;
        }

        public string getAddTime()
        {
            return this.addTime;
        }

        public int getValid()
        {
            return this.valid;
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public void setValid(int i)
        {
            this.valid = i;
        }

        public void setTemperature(float t)
        {
            this.temperature = t;
        }

        public void setAddTime(string time)
        {
            this.addTime = time;
        }

        public void setDevID(string devID)
        {
            this.devID = devID;
        }

        public String toString()
        {
            String str = "时间：\t";
            str += this.addTime;
            str += "\t温度：\t";
            str += Convert.ToString(this.temperature);
            str += "\t设备号： ";
            str += this.devID;
            return str;
        }
    }
}
