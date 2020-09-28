using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseScript : MonoBehaviour
{
    public TGrid<int> world;
    [SerializeField] float cellSize = 1f;
    [SerializeField] int width = 8, height = 5;
    [SerializeField] Vector3 originPos = new Vector3(-3,-5);


    // Start is called before the first frame update
    void Start()
    {
        world = new TGrid<int>(width, height, cellSize, originPos);
    }

    // Update is called once per frame
    void Update()
    {
        //tested it and start doesnt destroy the hold array lol worth looking at it tho
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Start();
        }

        //idk why but it doesnt work properly :/
        if(Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
        //primary click
        if(Input.GetMouseButtonDown(0))
        {
            Vector2Int MousePos = world.GetCell(TGrid<int>.GetMouseWorldPos());
            Debug.Log($"X = {MousePos.x}, Y = {MousePos.y}, VALUE : {world.gridArray[MousePos.x,MousePos.y]}");
        }

        //secondary click
        if(Input.GetMouseButtonDown(1)){
            int value = 26;
            world.SetValue(TGrid<int>.GetMouseWorldPos(), value);
        }

    }
}
