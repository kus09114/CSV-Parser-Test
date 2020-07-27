using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParserTestDlg : MonoBehaviour
{
	public Text m_txtResult = null;
	public Button m_btnLoad = null;
	public Button m_btnParser = null;
	public Button m_btnClear = null;

    void Start()
    {
		m_btnLoad.onClick.AddListener(OnClick_BtnLoad);
		m_btnParser.onClick.AddListener(OnClick_BtnParser);
		m_btnClear.onClick.AddListener(OnClick_BtnClear);
    }

	public void Initialize()
	{

	}

    void Update()
    {
        
    }

	public void OnClick_BtnLoad()
	{
		LoadingTest();
	}
	public void OnClick_BtnParser()
	{ 
 
	}
	public void OnClick_BtnClear()
	{

	}

	public void LoadingTest()
	{
		List<string[]> dataList = CSVParser.Load("TableData/test");
		//List<string[]> dataList = CSVParser.Load2("Assets/Resources/TableData/test.csv");

		string sResult = "";
		for(int i = 0; i < dataList.Count; i++)
		{
			string[] data = dataList[i];
			sResult += string.Format("{0} {1} {2}\n", data[0], data[1], data[2]);
		}
		m_txtResult.text = sResult;
	}
}
