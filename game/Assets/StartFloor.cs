using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartFloor : MonoBehaviour {

    public GameObject Floor;
    public GameObject Floor2;
    public GameObject Namu;

    void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            int num = Random.Range(0, 2);
            switch (num)
            {
                case 0:
                    Instantiate(Floor, this.transform.position + new Vector3(0, 0, i * 2), Quaternion.identity); // 생성 위치 지정
                    for (int j = 0; j < 4; j++)
                    { // 나무 4개 만들기
                        int num2 = Random.Range(0, 8);           // 0~7 까지 8개 중에 랜덤으로 한개
                        switch (num2)
                        {
                            case 0:
                                Instantiate(Namu, this.transform.position + new Vector3(-7, 0, i*2),
                                    Quaternion.identity); break; // 첫번째칸

                            case 1:
                                Instantiate(Namu, this.transform.position + new Vector3(-5, 0, i * 2),
                                    Quaternion.identity); break; // 두번째칸

                            case 2:
                                Instantiate(Namu, this.transform.position + new Vector3(-3, 0, i * 2),
                                    Quaternion.identity); break; // 세번째칸

                            case 3:
                                Instantiate(Namu, this.transform.position + new Vector3(-1, 0, i * 2),
                                    Quaternion.identity); break; // 네번째칸

                            case 4:
                                Instantiate(Namu, this.transform.position + new Vector3(1, 0, i * 2),
                                    Quaternion.identity); break;  // 다섯번째칸

                            case 5:
                                Instantiate(Namu, this.transform.position + new Vector3(3, 0, i * 2),
                                    Quaternion.identity); break;  // 여섯번째칸

                            case 6:
                                Instantiate(Namu, this.transform.position + new Vector3(5, 0, i * 2),
                                    Quaternion.identity); break;  // 일곱번째칸

                            case 7:
                                Instantiate(Namu, this.transform.position + new Vector3(7, 0, i * 2),
                                    Quaternion.identity); break;  // 여덟번째칸
                        }

                    }
                    break;
                case 1:
                    Instantiate(Floor2, this.transform.position + new Vector3(0, 0, i * 2), Quaternion.identity); // 생성 위치 지정
                    break;
            }
        }
    }
}
