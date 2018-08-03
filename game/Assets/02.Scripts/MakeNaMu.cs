using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeNaMu : MonoBehaviour
{

    public Transform prefab;
    int j = 2;                  // z 값 

    void Start()
    {

        InvokeRepeating("EX", 1, 2); // EX가 1초후 부터 2초마다 실행
    }

    void EX()
    {
        for (int i = 0; i < 4; i++)
        { // 나무 4개 만들기

            int num2 = Random.Range(0, 8);           // 0~7 까지 8개 중에 랜덤으로 한개

            switch (num2)
            {
                case 0:
                    Instantiate(prefab, new Vector3(-8, 0, j), Quaternion.identity); break; // 첫번째칸

                case 1:
                    Instantiate(prefab, new Vector3(-6, 0, j), Quaternion.identity); break; // 두번째칸

                case 2:
                    Instantiate(prefab, new Vector3(-4, 0, j), Quaternion.identity); break; // 세번째칸

                case 3:
                    Instantiate(prefab, new Vector3(-2, 0, j), Quaternion.identity); break; // 네번째칸

                case 4:
                    Instantiate(prefab, new Vector3(0, 0, j), Quaternion.identity); break;  // 다섯번째칸

                case 5:
                    Instantiate(prefab, new Vector3(2, 0, j), Quaternion.identity); break;  // 여섯번째칸

                case 6:
                    Instantiate(prefab, new Vector3(4, 0, j), Quaternion.identity); break;  // 일곱번째칸

                case 7:
                    Instantiate(prefab, new Vector3(6, 0, j), Quaternion.identity); break;  // 여덟번째칸
            }

        }

        j += 2;             // z값 2씩 증가 : 한칸앞에서 생성
    }
}
	

