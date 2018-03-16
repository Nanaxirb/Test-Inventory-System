using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ItemDatabase : MonoBehaviour {

    string path;
    string jsonString;

	void Start () {
        path = Application.streamingAssetsPath + "/Item.json";
        jsonString = File.ReadAllText(path);

	}
	

}

[System.Serializable]
public class Item {
    public int Id;
    public string Title;
    public int Value;

    public Item(int id, string title, int value) {
        this.Id = id;
        this.Title = title;
        this.Value = value;
    }
}

