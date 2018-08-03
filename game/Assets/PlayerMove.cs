using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public Rigidbody ActorBody = null;

	void Start () {
		
	}
	
    

    public enum E_DirectionType
    {
        Up = 0,
        Down,
        Left,
        Right
    }
    [SerializeField]
    protected E_DirectionType m_DirectionType = E_DirectionType.Up;

    protected void SetActorMove(E_DirectionType p_movetype)
    {
        Vector3 offsetpos = Vector3.zero;

        switch(p_movetype)
        {
            case E_DirectionType.Up:
                offsetpos = Vector3.forward * 2; // 앞 방향으로 1 이동 * 2
                break;
            case E_DirectionType.Down:
                offsetpos = Vector3.back * 2; // 뒤 방향으로 1 이동 * 2
                break;
            case E_DirectionType.Left:
                offsetpos = Vector3.left * 2; // 왼쪽 방향으로 1 이동 * 2
                break;
            case E_DirectionType.Right:
                offsetpos = Vector3.right * 2; // 오른쪽 방향으로 1 이동 * 2
                break;
            default:
                Debug.LogErrorFormat("SetActorMove Error : {0}",p_movetype); // 잘못된 입력시 출력
                break;
        }
        this.transform.position += offsetpos;
    }


	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            SetActorMove(E_DirectionType.Up);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetActorMove(E_DirectionType.Down);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SetActorMove(E_DirectionType.Left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SetActorMove(E_DirectionType.Right);
        }
    }
}
