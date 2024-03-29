using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPool : MonoBehaviour
{
    //[무한 생성기의 경우]
    // 1. Update 문으로 구현
    // 2. Coroutine을 이용한 설계

    public GameObject MonsterPrefab; // 몬스터 프리팹에 대한 값
    public int PoolSize; // 풀로 생성할 유닌의 개수

    public float spawnTime; //몬스터의 스폰시간

    GameObject[] monsterPool; // 몬스터에 대한 배열(몬스터 풀)

    //GameObject monsterSpawnPool;

    // Start is called before the first frame update
    void Start()
    {
        //monsterSpawnPool = new GameObject("monsterSpawnPool"); // 풀을 관리할 오브젝트

        //풀에서 설정된 사이즈만큼 오브젝트를 배열에 할당
        monsterPool = new GameObject[PoolSize];
        //할당한 배열만큼 생성
        Spwan(monsterPool, PoolSize);
        //특정 시간마다 몬스터가 생성될 수 있도록 코루틴을 작동
        StartCoroutine("MonsterPooling");
    }

    private void Spwan(GameObject[] monsterPool, int poolSize)
    {
        for (int i = 0; i < monsterPool.Length; i++)
        {
            monsterPool[i] = Instantiate(MonsterPrefab);
            monsterPool[i].name = "Monster_" + i;
            monsterPool[i].transform.parent = transform; // 풀을 부모로 등록
            //monsterPool[i].transform.parent = monsterSpawnPool.transform;
            //비활성화
            monsterPool[i].SetActive(false);
        }
    }

    IEnumerator MonsterPooling()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            for (int i = 0; i < PoolSize; i++)
            {
                if (monsterPool[i].activeSelf == true)
                {
                    continue;
                }
                float x = Random.Range(-5, 5);
                float y = Random.Range(-5, 5);

                monsterPool[i].transform.position = new Vector2(x, y);

                monsterPool[i].SetActive(true);
                break;
            }
        }
    }


}
