using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject[] monsterPrefabs;
    static int monsterCount = 0;
    public float spawnRadius=10f;

    private void Start()
    {
        StartCoroutine(MonsterSpawn());
    }
    public static int damage {  get; private set; }
    public static void setDamage(int d)
    {
        damage = d;
    }

    IEnumerator MonsterSpawn()
    {
        while (true)
        {
            if (monsterCount >= 5)
            {
                yield return new WaitForSeconds(3f);
                continue;
            }
            float angle = Random.Range(0, 360);
            Vector3 position = new Vector3(spawnRadius * Mathf.Cos(angle), spawnRadius * Mathf.Sin(angle), 0);
            Instantiate(monsterPrefabs[(int)Random.Range(0, 2)], position, transform.rotation);
            monsterCount++;
            yield return new WaitForSeconds(3f);
        }
    }


}
