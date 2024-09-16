using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlySound : MonoBehaviour
{
        public static  PlayerFlySound instance;

        public GameObject PlayerFly;

        private void Awake()
        {
            instance = this;
        }

    

}
