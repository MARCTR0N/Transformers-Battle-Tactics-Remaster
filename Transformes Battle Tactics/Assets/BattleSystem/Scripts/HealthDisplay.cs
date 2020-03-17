using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Battle;


namespace Battle
{

    public class HealthDisplay : MonoBehaviour
    {
        
        private int health = 5;
        public Text healthText;
        public GameObject HealthValue;

        //Battle.BattleHandler battleHandler = new BattleHandler();

            

        public Vector3 position1 = new Vector3(-30, -10);
        public Vector3 position2 = new Vector3(-30, 20);
        public Vector3 position3 = new Vector3(-60, -10);
        public Vector3 position4 = new Vector3(-60, 20);

        private void Start()
        {
            GameObject HealthValue = new GameObject("HealthValue");
            
            healthText.transform.SetParent(transform);

            healthText.rectTransform.position = new Vector3(-227.5f, -80, 0); //position1 + new Vector3(-396, -160, 0)
        }

        void Update()
        {
            //healthText.transform.Rotate(0,1,0);
           //healthText.transform.Translate(0.4f, 0f, 0);

            Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
            //healthText.transform.position = position1;
          

            //healthText.rectTransform.position = new Vector3(-30, -10); //position1 + new Vector3(-396, -160, 0)
            healthText.text = "" + health;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                health++;
            }
        }
    }
}