using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class forSaveLoad : MonoBehaviour
{
    public Text adText;
    public Text puanText;

    public InputField adVeri;
    public InputField puanVeri;


    void Start()
    {
        Load();
    }
    public void Save()
    {
        mineData.ad = adVeri.text;
        mineData.puan = int.Parse(puanVeri.text);
        SaveLoadSystem.SaveSystem();
    }

    public void Load()
    {
        SaveLoadSystem.LoadSystem();
        adText.text = mineData.ad;
        puanText.text = mineData.puan.ToString();
    }

}
