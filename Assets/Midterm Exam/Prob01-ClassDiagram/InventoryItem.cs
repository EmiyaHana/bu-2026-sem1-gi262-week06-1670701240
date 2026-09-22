using UnityEngine;

namespace MidtermExam.Prob01
{
    public class InventoryItem : MonoBehaviour
    {
        public string itemName;
        protected int weight;
        private int itemValue;

        public virtual void Use(Character user)
        {

        }
    }
}
