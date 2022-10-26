using System;
using System.Collections.Generic;
using UnityEngine;

public class Clothes : MonoBehaviour
{
    [SerializeField] private List<GameObject> listClothes = new List<GameObject>();

    private void Start()
    {
        foreach (var item in listClothes)
        {
            var name = PlayerPrefs.GetString(item.name) == "True" ? true : false;
            print(name);
            item.SetActive(name);
            
        }
    }

    public void Switching(int index)
    {
        if (listClothes[index].activeSelf)
        {
            listClothes[index].SetActive(false);
        }
        else
        {
            listClothes[index].SetActive(true);
        }
    }

    public void Reset()
    {
        foreach (var item in listClothes)
        {
            item.SetActive(false);
        }
    }

    public void Save()
    {
        foreach (var item in listClothes)
        {
            if (item.activeSelf)
            {
                PlayerPrefs.SetString(item.name, item.active.ToString());
            }
            else
            {
                PlayerPrefs.SetString(item.name, "False");
            }
        }
    }
}
