using UnityEngine;

public class MoveBackground : MonoBehaviour {

	public enum ProjectMode {moveX = 0, moveY = 1};
	public ProjectMode projectMode = ProjectMode.moveX;

	public MeshRenderer firstBG;
	public float firstBGSpeed = 0.01f;

	public MeshRenderer secondBG;
	public float secondBGSpeed = 0.05f;

	public MeshRenderer thirdBG;
	public float thirdBGSpeed = 0.1f;

	private Vector2 _savedFirst;
	private Vector2 _savedSecond;
	private Vector2 _savedThird;
	
	private void Awake()
	{
		if(firstBG) _savedFirst = firstBG.sharedMaterial.GetTextureOffset("_MainTex");
		if(secondBG) _savedSecond = secondBG.sharedMaterial.GetTextureOffset("_MainTex");
		if(thirdBG) _savedThird = thirdBG.sharedMaterial.GetTextureOffset("_MainTex");
	}

	private void Move(MeshRenderer mesh, Vector2 savedOffset, float speed)
	{
		Vector2 offset = Vector2.zero;
		float tmp = Mathf.Repeat(Time.time * speed, 1);
		if(projectMode == ProjectMode.moveY) offset = new Vector2(savedOffset.x, tmp);
		else offset = new Vector2(tmp, savedOffset.y);
		mesh.sharedMaterial.SetTextureOffset("_MainTex", offset);
	}
	
	private void Update()
	{
		if(firstBG) Move(firstBG, _savedFirst, firstBGSpeed);
		if(secondBG) Move(secondBG, _savedSecond, secondBGSpeed);
		if(thirdBG) Move(thirdBG, _savedThird, thirdBGSpeed);
	}
	
	private void OnDisable()
	{
		if(firstBG) firstBG.sharedMaterial.SetTextureOffset("_MainTex", _savedFirst);
		if(secondBG) secondBG.sharedMaterial.SetTextureOffset("_MainTex", _savedSecond);
		if(thirdBG) thirdBG.sharedMaterial.SetTextureOffset("_MainTex", _savedThird);
	}
}