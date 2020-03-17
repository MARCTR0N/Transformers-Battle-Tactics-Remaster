using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Battle;

namespace Battle
{
    public class CharacterBattleSlot : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] public Transform Rarity;
        [SerializeField] public Transform CharacterShadow;



        public int rarity;

        //BotGuiPos

        void Start()
        {
            Battle.Dummy dummy = new Dummy();
            TransformerRarity(rarity);

            Battle.HealthDisplay health = new HealthDisplay();

            GameObject Slot = new GameObject("Slot");
            Rarity.transform.SetParent(transform);
            CharacterShadow.transform.SetAsLastSibling();
            health.HealthValue.transform.SetParent(transform);
            

            
            RenderShadow(true);
        }

        // Update is called once per frame
        void Update()
        {
            
            transform.position = transform.position + new Vector3(0.1f, 0, 0);
            
        }

        public void RenderShadow(bool renderShadow)
        {
            Battle.BattleHandler battleHandler = new BattleHandler();
            if (renderShadow)
            {
                Instantiate(CharacterShadow, battleHandler.Pposition1 + new Vector3(-64.5f, -27, 0), Quaternion.identity);
            }

        }

        public void TransformerRarity(int rarity)
        {
            Battle.BattleHandler battleHandler = new BattleHandler();
            
            if (rarity >= 1)
            { 
                Instantiate(Rarity, battleHandler.Pposition1 + new Vector3(-230, -50, 0), Quaternion.identity);
            }
            if (rarity >= 2)
            {
                Instantiate(Rarity, battleHandler.Pposition1 + new Vector3(-230, -38, 0), Quaternion.identity);
            }
            if (rarity >= 3)
            {
                Instantiate(Rarity, battleHandler.Pposition1 + new Vector3(-230, -26, 0), Quaternion.identity);
            }
            if (rarity >= 4)
            {
                Instantiate(Rarity, battleHandler.Pposition1 + new Vector3(-230, -14, 0), Quaternion.identity);
            }
            if (rarity >= 5)
            {
                Instantiate(Rarity, battleHandler.Pposition1 + new Vector3(-230, -2, 0), Quaternion.identity);
            }
        }

        public void TransformerClass(string name)
        {
            if (name == "Combiner")
            {

            }
        }

        public void BotGui(bool hasBotGui)
        {
            if (hasBotGui)
            {
                
            }



        }
    }
}
