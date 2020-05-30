using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    private Text _pointText;
    private int _points = 0;

    // Start is called before the first frame update
    void Start()
    {
        _pointText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        _pointText.text = "Score: " + _points.ToString();
    }

    public void Add()
    {
        _points++;
    }

    public int GetPoints()
    {
        return _points;
    }
}
