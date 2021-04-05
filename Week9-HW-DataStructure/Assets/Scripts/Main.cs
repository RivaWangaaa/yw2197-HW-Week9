using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    private List<string> lines;
    
    private Queue<string> result = new Queue<string>();
    
    public TextAsset textFileWithLines;

    public Text resultDisplay;

    private int count = 3;

    public GameObject finishButton;
    public GameObject restartButton;
    public GameObject insertBar;
    public GameObject description;
    
    // Start is called before the first frame update
    void Start()
    {
        insertBar.SetActive(true);
        lines = new List<string>();
        
        var linesFromFile = textFileWithLines.text.Split('\n');
        
        for (var i = 0; i < linesFromFile.Length; i++)
        {
            // Add each line to the list of names.
            lines.Add(linesFromFile[i]);
        }
        
        Debug.Log("Count: " + lines.Count);
    }
    
    

    // Update is called once per frame
    void Update()
    {
        if (lines[count] == null)
        {
            count += 1;
            if (count < 1)
            {
                count = 1;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            Debug.Log("Count is null, +1 ing...");
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.M) )
        {
            count += 1;
            
            if (count < 1)
            {
                count = 1;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.B)|| Input.GetKeyDown(KeyCode.N))
        {
            count -= 1;
            
            if (count < 1)
            {
                count = 1;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.C)|| Input.GetKeyDown(KeyCode.O))
        {
            count *= 2;
            
            if (count < 1)
            {
                count = 1;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.P))
        {
            count += 2;
            
            if (count < 1)
            {
                count = 1;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.E)|| Input.GetKeyDown(KeyCode.R))
        {
            count -= 2;
            
            if (count < 1)
            {
                count = 1;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.F)|| Input.GetKeyDown(KeyCode.S))
        {
            count += 3;
            
            if (count < 1)
            {
                count = 0;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.G)|| Input.GetKeyDown(KeyCode.T))
        {
            count -= 3;
            
            if (count < 1)
            {
                count = 0;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.H)|| Input.GetKeyDown(KeyCode.U))
        {
            count += 5;
            
            if (count < 1)
            {
                count = 0;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.I)|| Input.GetKeyDown(KeyCode.V))
        {
            count -= 5;
            
            if (count < 1)
            {
                count = 0;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.K)|| Input.GetKeyDown(KeyCode.W))
        {
            count += 10;
            
            if (count < 1)
            {
                count = 0;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        if (Input.GetKeyDown(KeyCode.L)|| Input.GetKeyDown(KeyCode.Y))
        {
            count -= 10;
            
            if (count < 1)
            {
                count = 0;
            }

            if (count > 50)
            {
                count = 50;
            }
            
            result.Enqueue(lines[count]);
            lines.RemoveAt(count);
        }
        
        
    }

    //when press 'finish' button, trigger this
    public void DisplayResult()
    {
        finishButton.SetActive(false);
        restartButton.SetActive(true);
        insertBar.SetActive(false);
        description.SetActive(false);
        while (result.Count > 0)
        {
            resultDisplay.text += "\n" + "\n" + result.Dequeue();
        }
            
    }

    //when press 'restart' button, trigger this
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
