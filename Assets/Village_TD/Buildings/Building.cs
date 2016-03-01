



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Village_TD
{
    class Building:MonoBehaviour //abstract zorgt ervoor dat er geen nieuwe instanties van building gemaakt kunnen worden.
    {
        private int level; //start level=1
        public Text levelText;

        void Start()
        {
            level = 1;
            setLevelText();
        }


        void setLevelText()
        {
            levelText.text = "level: " + level.ToString();
        }

        public int Level
        {
            get
            {
                return level;
            }
            private set
            {
                level = value;
                setLevelText();
            }

        }
        
        public void upgrade()    //methode om te upgraden.
        {                       
            Level++;
            
        }
    
    }
}
