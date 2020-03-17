using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

namespace Battle
{
    
    public class BattleHandler : MonoBehaviour
    {
        public static System.Text.Encoding UTF8 { get; }
        //[SerializeField] private Transform pfBumblebee;
        [SerializeField] private Transform DummyModelShadow;
       


        public Transform Slot1;
        public Transform Slot2;
        public Transform Slot3;
        public Transform Slot4;
        public Transform Slot5;

        public Vector3 Pposition1;
      

        public Vector3 Eposition1;
      

        private void Start()
        {
            

            Slot1 = DummyModelShadow;
            //Slot2 = DummyModel;
            //Slot3 = DummyModel;
            //Slot4 = DummyModel;


            
            SpawnTeam(true);
           //SpawnTeam(false);
        }

        public void SpawnTeam(bool isPlayerTeam)
        {
            Pposition1 = new Vector3(-30, -10);
           

            Eposition1 = new Vector3(30, -10, -20);
        
            Quaternion rotation;
            if (isPlayerTeam)
            {
                rotation = Quaternion.EulerRotation(0, 0, 0);

                Instantiate(Slot1, Pposition1, rotation);
                
            }
            else
            {
                rotation = Quaternion.EulerRotation(0, 3.14159265359f, 0);

                Instantiate(Slot1, Eposition1, rotation);
               
               
            }
            
            //Instantiate(Slot1, new Vector3(-5, 0), Quaternion.identity);
        }



    }
}