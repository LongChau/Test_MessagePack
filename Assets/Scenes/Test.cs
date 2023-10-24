using MessagePack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using static Test;

public class Test : MonoBehaviour
{
    public UserData _userData;

    // Start is called before the first frame update
    async void Start()
    {
        await Save();
        await LoadData();
    }

    [ContextMenu("Save")]
    private async Task<bool> Save()
    {
        var userData = new UserData
        {
            age = 1,
            city = "SAIGON",
            email = "longcd@vng",
            name = "Test_2",
            password = "password",
            //phone = "1234567890",
            ownChars = new Dictionary<CharacterType, int>
            {
                { CharacterType.Human, 10 }, { CharacterType.Orc, 5 }, { CharacterType.Shaman, 2 }
            },
            buildings = new List<Building> 
            { 
                new Building { name = "MainHall" },
                new Building { name = "Barrack" },
                new Building { name = "Tavern" },
                new Building { name = "LumberMill" },
                new Building { name = "DragonGate" },
                new Building { name = "ChampionHall" },
            }
        };

        // Call Serialize/Deserialize, that's all.
        byte[] bytes = MessagePackSerializer.Serialize(userData);
        UserData data = MessagePackSerializer.Deserialize<UserData>(bytes);

        // You can dump MessagePack binary blobs to human readable json.
        // Using indexed keys (as opposed to string keys) will serialize to MessagePack arrays,
        // hence property names are not available.
        // [99,"hoge","huga"]
        var json = MessagePackSerializer.ConvertToJson(bytes);
        Debug.Log(json);

        // Save
        var path = Path.Combine(Application.persistentDataPath, "Map_1.bin");
        //if (!File.Exists(path))
        //    File.Create(path);
        //File.WriteAllBytesAsync(path, bytes, destroyCancellationToken);

        await WriteFileAsync(path, bytes);
        return true;
    }

    [ContextMenu("LoadData")]
    public async Task<bool> LoadData()
    {
        var path = Path.Combine(Application.persistentDataPath, "Map_1.bin");
        Debug.Log($"Load at: {path}");
        if (!File.Exists(path)) return false; // No state to load

        byte[] bytes = await File.ReadAllBytesAsync(path);
        _userData = MessagePackSerializer.Deserialize<UserData>(bytes);
        return true;
    }

    public async Task<bool> WriteFileAsync(string filePath, byte[] data)
    {
        using (FileStream sourceStream = new FileStream
            (filePath, FileMode.OpenOrCreate,
            FileAccess.ReadWrite,
            FileShare.None,
            bufferSize: data.Length,
            useAsync: true))
        {
            await sourceStream.WriteAsync(data, 0, data.Length, destroyCancellationToken);
            Debug.Log("WriteFileAsync finished");
            return true;
        };
    }

    [ContextMenu("OpenSaveLocation")]
    void OpenSaveLocation()
    {
        Application.OpenURL(Application.persistentDataPath);
    }

    [Serializable]
    [MessagePackObject(true)]
    public class UserData
    {
        //[Key(0)]
        public string name;
        //[Key(1)]
        public string password;
        //[Key(2)]
        public string email;
        //[Key(3)]
        //public string phone;
        //[Key(4)]
        public int age;
        //[Key(5)]
        public string city;
        //[Key(6)]
        public Dictionary<CharacterType, int> ownChars;
        //[Key(7)]
        public List<Building> buildings;
    }

    public enum CharacterType
    {
        None = 0,
        Human,
        Orc,
        Shaman,
        NightElf,
    }

    [MessagePackObject(true)]
    [Serializable]
    public struct Building
    {
        public string name;
    }
}
