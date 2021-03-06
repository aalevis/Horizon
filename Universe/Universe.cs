using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace HSFUniverse{
    //Old implementation of universe. To be modified drastically by trent's thesis.
    public class Universe{
        public Sun Sun { get; private set; }
        
        public Universe(){
            Sun = new Sun(false);
        }
        public Universe(Sun sun)
        {
            Sun = sun;
        }

        public Universe(XmlNode environmentNode){
            // Check the XMLNode for the presence of a child SUN node

   
            if (environmentNode["SUN"] != null)
            {
                // Create the Sun based on the XMLNode                
                XmlNode sunNode = environmentNode["SUN"];
                // Check the Sun XMLNode for the attribute
                if(sunNode.Attributes["isSunVectConstant"] != null)
                {
                    bool sunVecConst = Convert.ToBoolean(sunNode.Attributes["isSunVecConstant"]);
                    Sun = new Sun(sunVecConst);
                }
                Sun = new Sun();
            }
            else{
                Sun = new Sun();
            }
        }
        

        
        
    }
}