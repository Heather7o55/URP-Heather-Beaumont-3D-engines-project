using System.Collections;
using System.Collections.Generic;
using UnityEditor.Formats.Fbx.Exporter;
using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Item")]
public class Item : ScriptableObject
{
    public new string name;
    public Sprite artwork;
    public GameObject model;
    public int ID;
}
