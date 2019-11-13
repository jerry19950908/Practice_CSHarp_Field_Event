using UnityEngine;

public class 小雞 : MonoBehaviour
{
    [Header("移動速度"), Range(0.5f, 100f)]
    public float speed = 20.5f;
    [Header("跳躍高度"), Range(10, 2000)]
    public int jump = 30;
    [Header("對話內容")]
    public string talk = "咕咕咕~~";
    [Header("是否取得雞蛋")]
    public bool egg;

    private void Start()
    {
        print("遊戲開始~");
    }

    private void Update()
    {
        print("咕咕咕~~");
    }
}
