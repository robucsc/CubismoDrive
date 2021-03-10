using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[System.Serializable]
class SaveGame {
    public Vector3 player_position;
}

// public class SaveLoad : MonoBehaviour {
//     
//     void Start()
//     {
//         var save_path = this.SaveGamePath();
//         Debug.Log("Looking for save file: " + save_path);
//     
//         if (System.IO.File.Exists(save_path))
//         {
//             Debug.Log("Found save file");
//             var contents = System.IO.File.ReadAllText(save_path);
//             var save_game = JsonUtility.FromJson<SaveGame>(contents);
//             this.transform.position = save_game.player_position;
//             Debug.Log(System.IO.File.ReadAllText(save_path));
//         } else {Debug.Log("No existing save");}
//     }
//     
//     private void OnApplicationQuit() {
//         // throw new NotImplementedException();
//         Debug.Log("Save Game");
//         
//         var save_game = new SaveGame();
//         save_game.player_position = this.transform.position;
//         var save_string = JasonUtility.ToJson(save_game, true);
//
//         var save_path = Application.persistentDataPath + "/save_slot_0.json";
//         Debug.Log("Saving to: " + save_path);
//         
//         var file = new System.IO.StreamWriter(save_path);
//         file.Write(save_string);
//         file.Close();
//     }
// }

