using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFactory : MonoBehaviour
{
    #region singleton
    private static ObjectFactory instance = null;
    
    public static ObjectFactory Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<ObjectFactory>();
            }

            return instance;
        }
    }
    #endregion

    [SerializeField] private Food foodPrefab;

    public List<GameObject> objects;

    private void Start()
    {
        objects = new List<GameObject>();
        objects.Add(foodPrefab.gameObject);
    }

    public ISpawn GetObject(string name)
    {
        if(name == "Food")
        {
            //cari prefab food
            foreach(GameObject obj in objects)
            {
                if (obj.name == name)
                {
                    //clone prefab
                    Food foodObj = Instantiate(obj).GetComponent<Food>();
                    foodObj.SpawnPosition();

                    //return prefab
                    return foodObj;
                }
            }
        }
        //tambahkan else if disini untuk create object dengan tipe ISpawn lainnya 

        return null;
    }
}
