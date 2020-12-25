using UnityEngine;

public class test : MonoBehaviour
{
    /// <summary>
    /// 测试
    /// </summary>
    public GameObject _Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // TODO: 测试使用
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("OK!");
        }
    }
}
