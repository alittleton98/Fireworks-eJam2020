using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObjectManager
{

    enum PlayerColor
    {
        RED,
        BLUE,
        GREEN,
        YELLOW
    }
    public class Player : MonoBehaviour
    {
        int playerID;
        string playerName;
        Vector3 playerPos;
        PlayerColor playerColor;
        Rigidbody rb;
        string tag;

        public int PlayerID { get => playerID; set => playerID = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
        public string Tag { get => tag; set => tag = value; }
        public Rigidbody Rb { get => rb; set => rb = value; }
        internal PlayerColor PlayerColor { get => playerColor; set => playerColor = value; }
    }
}

