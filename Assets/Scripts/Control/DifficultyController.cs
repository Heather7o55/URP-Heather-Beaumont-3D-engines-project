using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyController : MonoBehaviour
{
    // Start is called before the first frame update
   public struct Difficulty
    {
        public int low;
        public int high;
        public int maxRequests;
    }
    public static Difficulty difficulty;
}
