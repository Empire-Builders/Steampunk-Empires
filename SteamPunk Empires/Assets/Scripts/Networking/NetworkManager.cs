using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	
	private const string typeName = "SteampunkEmpires";
	private HostData[] hostList;

	public Image createServerButton;
	public Image showServerListButton;
	public GameObject serverCreatedImage;
	public string gameName;
	
	public void StartServer()
	{
		Network.InitializeServer(4, 10012, !Network.HavePublicAddress());
		MasterServer.RegisterHost(typeName, gameName);
	}
	
	void OnServerInitialized()
	{
		Debug.Log("Server Initializied");
		createServerButton.enabled = false;
		createServerButton.GetComponentInChildren<Text>().enabled = false;
		showServerListButton.enabled = false;
		showServerListButton.GetComponentInChildren<Text>().enabled = false;
		serverCreatedImage.SetActive(true);

	}
	
	public void RefreshHostList()
	{
		MasterServer.RequestHostList(typeName);
	}
	
	void OnMasterServerEvent(MasterServerEvent msEvent)
	{
		if (msEvent == MasterServerEvent.HostListReceived)
			hostList = MasterServer.PollHostList();
	}
	
	private void JoinServer(HostData hostData)
	{
		Network.Connect(hostData);
	}
	
	void OnConnectedToServer()
	{
		Debug.Log("Server Joined");
	}
}
