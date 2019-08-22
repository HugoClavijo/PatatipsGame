extern "C" void RegisterStaticallyLinkedModulesGranular()
{
	void RegisterModule_SharedInternals();
	RegisterModule_SharedInternals();

	void RegisterModule_Core();
	RegisterModule_Core();

	void RegisterModule_Animation();
	RegisterModule_Animation();

	void RegisterModule_Audio();
	RegisterModule_Audio();

	void RegisterModule_Physics2D();
	RegisterModule_Physics2D();

	void RegisterModule_TextRendering();
	RegisterModule_TextRendering();

	void RegisterModule_UI();
	RegisterModule_UI();

	void RegisterModule_UnityConnect();
	RegisterModule_UnityConnect();

	void RegisterModule_IMGUI();
	RegisterModule_IMGUI();

	void RegisterModule_UnityWebRequest();
	RegisterModule_UnityWebRequest();

	void RegisterModule_UnityAnalytics();
	RegisterModule_UnityAnalytics();

	void RegisterModule_TLS();
	RegisterModule_TLS();

	void RegisterModule_JSONSerialize();
	RegisterModule_JSONSerialize();

}

template <typename T> void RegisterUnityClass(const char*);
template <typename T> void RegisterStrippedType(int, const char*, const char*);

void InvokeRegisterStaticallyLinkedModuleClasses()
{
	// Do nothing (we're in stripping mode)
}

namespace ObjectProduceTestTypes { class Derived; } 
namespace ObjectProduceTestTypes { class SubDerived; } 
class EditorExtension; template <> void RegisterUnityClass<EditorExtension>(const char*);
namespace Unity { class Component; } template <> void RegisterUnityClass<Unity::Component>(const char*);
class Behaviour; template <> void RegisterUnityClass<Behaviour>(const char*);
class Animation; 
class Animator; template <> void RegisterUnityClass<Animator>(const char*);
class AudioBehaviour; template <> void RegisterUnityClass<AudioBehaviour>(const char*);
class AudioListener; template <> void RegisterUnityClass<AudioListener>(const char*);
class AudioSource; template <> void RegisterUnityClass<AudioSource>(const char*);
class AudioFilter; 
class AudioChorusFilter; 
class AudioDistortionFilter; 
class AudioEchoFilter; 
class AudioHighPassFilter; 
class AudioLowPassFilter; 
class AudioReverbFilter; 
class AudioReverbZone; 
class Camera; template <> void RegisterUnityClass<Camera>(const char*);
namespace UI { class Canvas; } template <> void RegisterUnityClass<UI::Canvas>(const char*);
namespace UI { class CanvasGroup; } template <> void RegisterUnityClass<UI::CanvasGroup>(const char*);
namespace Unity { class Cloth; } 
class Collider2D; template <> void RegisterUnityClass<Collider2D>(const char*);
class BoxCollider2D; template <> void RegisterUnityClass<BoxCollider2D>(const char*);
class CapsuleCollider2D; 
class CircleCollider2D; template <> void RegisterUnityClass<CircleCollider2D>(const char*);
class CompositeCollider2D; 
class EdgeCollider2D; template <> void RegisterUnityClass<EdgeCollider2D>(const char*);
class PolygonCollider2D; 
class TilemapCollider2D; 
class ConstantForce; 
class Effector2D; 
class AreaEffector2D; 
class BuoyancyEffector2D; 
class PlatformEffector2D; 
class PointEffector2D; 
class SurfaceEffector2D; 
class FlareLayer; 
class GUIElement; template <> void RegisterUnityClass<GUIElement>(const char*);
namespace TextRenderingPrivate { class GUIText; } 
class GUITexture; 
class GUILayer; template <> void RegisterUnityClass<GUILayer>(const char*);
class GridLayout; 
class Grid; 
class Tilemap; 
class Halo; 
class HaloLayer; 
class IConstraint; 
class AimConstraint; 
class LookAtConstraint; 
class ParentConstraint; 
class PositionConstraint; 
class RotationConstraint; 
class ScaleConstraint; 
class Joint2D; 
class AnchoredJoint2D; 
class DistanceJoint2D; 
class FixedJoint2D; 
class FrictionJoint2D; 
class HingeJoint2D; 
class SliderJoint2D; 
class SpringJoint2D; 
class WheelJoint2D; 
class RelativeJoint2D; 
class TargetJoint2D; 
class LensFlare; 
class Light; 
class LightProbeGroup; 
class LightProbeProxyVolume; 
class MonoBehaviour; template <> void RegisterUnityClass<MonoBehaviour>(const char*);
class NavMeshAgent; 
class NavMeshObstacle; 
class OffMeshLink; 
class ParticleSystemForceField; 
class PhysicsUpdateBehaviour2D; 
class ConstantForce2D; 
class PlayableDirector; 
class Projector; 
class ReflectionProbe; template <> void RegisterUnityClass<ReflectionProbe>(const char*);
class Skybox; 
class SortingGroup; 
class StreamingController; 
class Terrain; 
class VideoPlayer; 
class VisualEffect; 
class WindZone; 
namespace UI { class CanvasRenderer; } template <> void RegisterUnityClass<UI::CanvasRenderer>(const char*);
class Collider; 
class BoxCollider; 
class CapsuleCollider; 
class CharacterController; 
class MeshCollider; 
class SphereCollider; 
class TerrainCollider; 
class WheelCollider; 
class FakeComponent; 
namespace Unity { class Joint; } 
namespace Unity { class CharacterJoint; } 
namespace Unity { class ConfigurableJoint; } 
namespace Unity { class FixedJoint; } 
namespace Unity { class HingeJoint; } 
namespace Unity { class SpringJoint; } 
class LODGroup; 
class MeshFilter; template <> void RegisterUnityClass<MeshFilter>(const char*);
class OcclusionArea; 
class OcclusionPortal; 
class ParticleSystem; 
class Renderer; template <> void RegisterUnityClass<Renderer>(const char*);
class BillboardRenderer; 
class LineRenderer; 
class RendererFake; 
class MeshRenderer; template <> void RegisterUnityClass<MeshRenderer>(const char*);
class ParticleSystemRenderer; 
class SkinnedMeshRenderer; 
class SpriteMask; 
class SpriteRenderer; template <> void RegisterUnityClass<SpriteRenderer>(const char*);
class SpriteShapeRenderer; 
class TilemapRenderer; 
class TrailRenderer; 
class VFXRenderer; 
class Rigidbody; 
class Rigidbody2D; template <> void RegisterUnityClass<Rigidbody2D>(const char*);
namespace TextRenderingPrivate { class TextMesh; } 
class Transform; template <> void RegisterUnityClass<Transform>(const char*);
namespace UI { class RectTransform; } template <> void RegisterUnityClass<UI::RectTransform>(const char*);
class Tree; 
class WorldAnchor; 
class GameObject; template <> void RegisterUnityClass<GameObject>(const char*);
class NamedObject; template <> void RegisterUnityClass<NamedObject>(const char*);
class AssetBundle; 
class AssetBundleManifest; 
class ScriptedImporter; 
class AudioMixer; 
class AudioMixerController; 
class AudioMixerGroup; 
class AudioMixerGroupController; 
class AudioMixerSnapshot; 
class AudioMixerSnapshotController; 
class Avatar; 
class AvatarMask; 
class BillboardAsset; 
class ComputeShader; template <> void RegisterUnityClass<ComputeShader>(const char*);
class Flare; 
namespace TextRendering { class Font; } template <> void RegisterUnityClass<TextRendering::Font>(const char*);
class GameObjectRecorder; 
class LightProbes; 
class LocalizationAsset; 
class Material; template <> void RegisterUnityClass<Material>(const char*);
class ProceduralMaterial; 
class Mesh; template <> void RegisterUnityClass<Mesh>(const char*);
class Motion; template <> void RegisterUnityClass<Motion>(const char*);
class AnimationClip; template <> void RegisterUnityClass<AnimationClip>(const char*);
class PreviewAnimationClip; 
class NavMeshData; 
class OcclusionCullingData; 
class PhysicMaterial; 
class PhysicsMaterial2D; 
class PreloadData; template <> void RegisterUnityClass<PreloadData>(const char*);
class RuntimeAnimatorController; template <> void RegisterUnityClass<RuntimeAnimatorController>(const char*);
class AnimatorController; template <> void RegisterUnityClass<AnimatorController>(const char*);
class AnimatorOverrideController; template <> void RegisterUnityClass<AnimatorOverrideController>(const char*);
class SampleClip; template <> void RegisterUnityClass<SampleClip>(const char*);
class AudioClip; template <> void RegisterUnityClass<AudioClip>(const char*);
class Shader; template <> void RegisterUnityClass<Shader>(const char*);
class ShaderVariantCollection; 
class SpeedTreeWindAsset; 
class Sprite; template <> void RegisterUnityClass<Sprite>(const char*);
class SpriteAtlas; template <> void RegisterUnityClass<SpriteAtlas>(const char*);
class SubstanceArchive; 
class TerrainData; 
class TerrainLayer; 
class TextAsset; template <> void RegisterUnityClass<TextAsset>(const char*);
class CGProgram; 
class MonoScript; template <> void RegisterUnityClass<MonoScript>(const char*);
class Texture; template <> void RegisterUnityClass<Texture>(const char*);
class BaseVideoTexture; 
class MovieTexture; 
class WebCamTexture; 
class CubemapArray; template <> void RegisterUnityClass<CubemapArray>(const char*);
class LowerResBlitTexture; template <> void RegisterUnityClass<LowerResBlitTexture>(const char*);
class ProceduralTexture; 
class RenderTexture; template <> void RegisterUnityClass<RenderTexture>(const char*);
class CustomRenderTexture; 
class SparseTexture; 
class Texture2D; template <> void RegisterUnityClass<Texture2D>(const char*);
class Cubemap; template <> void RegisterUnityClass<Cubemap>(const char*);
class Texture2DArray; template <> void RegisterUnityClass<Texture2DArray>(const char*);
class Texture3D; template <> void RegisterUnityClass<Texture3D>(const char*);
class VideoClip; 
class VisualEffectAsset; 
class VisualEffectResource; 
class GameManager; template <> void RegisterUnityClass<GameManager>(const char*);
class GlobalGameManager; template <> void RegisterUnityClass<GlobalGameManager>(const char*);
class AudioManager; template <> void RegisterUnityClass<AudioManager>(const char*);
class BuildSettings; template <> void RegisterUnityClass<BuildSettings>(const char*);
class ClusterInputManager; 
class DelayedCallManager; template <> void RegisterUnityClass<DelayedCallManager>(const char*);
class GraphicsSettings; template <> void RegisterUnityClass<GraphicsSettings>(const char*);
class InputManager; template <> void RegisterUnityClass<InputManager>(const char*);
class MonoManager; template <> void RegisterUnityClass<MonoManager>(const char*);
class NavMeshProjectSettings; 
class Physics2DSettings; template <> void RegisterUnityClass<Physics2DSettings>(const char*);
class PhysicsManager; 
class PlayerSettings; template <> void RegisterUnityClass<PlayerSettings>(const char*);
class QualitySettings; template <> void RegisterUnityClass<QualitySettings>(const char*);
class ResourceManager; template <> void RegisterUnityClass<ResourceManager>(const char*);
class RuntimeInitializeOnLoadManager; template <> void RegisterUnityClass<RuntimeInitializeOnLoadManager>(const char*);
class ScriptMapper; template <> void RegisterUnityClass<ScriptMapper>(const char*);
class StreamingManager; 
class TagManager; template <> void RegisterUnityClass<TagManager>(const char*);
class TimeManager; template <> void RegisterUnityClass<TimeManager>(const char*);
class UnityConnectSettings; template <> void RegisterUnityClass<UnityConnectSettings>(const char*);
class VFXManager; 
class LevelGameManager; template <> void RegisterUnityClass<LevelGameManager>(const char*);
class LightmapSettings; template <> void RegisterUnityClass<LightmapSettings>(const char*);
class NavMeshSettings; 
class OcclusionCullingSettings; 
class RenderSettings; template <> void RegisterUnityClass<RenderSettings>(const char*);
class NativeObjectType; 
class PropertyModificationsTargetTestObject; 
class SerializableManagedHost; 
class SerializableManagedRefTestClass; 
namespace ObjectProduceTestTypes { class SiblingDerived; } 
class TestObjectVectorPairStringBool; 
class TestObjectWithSerializedAnimationCurve; 
class TestObjectWithSerializedArray; 
class TestObjectWithSerializedMapStringBool; 
class TestObjectWithSerializedMapStringNonAlignedStruct; 
class TestObjectWithSpecialLayoutOne; 
class TestObjectWithSpecialLayoutTwo; 

void RegisterAllClasses()
{
void RegisterBuiltinTypes();
RegisterBuiltinTypes();
	//Total: 73 non stripped classes
	//0. Camera
	RegisterUnityClass<Camera>("Core");
	//1. Behaviour
	RegisterUnityClass<Behaviour>("Core");
	//2. Unity::Component
	RegisterUnityClass<Unity::Component>("Core");
	//3. EditorExtension
	RegisterUnityClass<EditorExtension>("Core");
	//4. ReflectionProbe
	RegisterUnityClass<ReflectionProbe>("Core");
	//5. QualitySettings
	RegisterUnityClass<QualitySettings>("Core");
	//6. GlobalGameManager
	RegisterUnityClass<GlobalGameManager>("Core");
	//7. GameManager
	RegisterUnityClass<GameManager>("Core");
	//8. Renderer
	RegisterUnityClass<Renderer>("Core");
	//9. Shader
	RegisterUnityClass<Shader>("Core");
	//10. NamedObject
	RegisterUnityClass<NamedObject>("Core");
	//11. Material
	RegisterUnityClass<Material>("Core");
	//12. MeshFilter
	RegisterUnityClass<MeshFilter>("Core");
	//13. MeshRenderer
	RegisterUnityClass<MeshRenderer>("Core");
	//14. Mesh
	RegisterUnityClass<Mesh>("Core");
	//15. Texture
	RegisterUnityClass<Texture>("Core");
	//16. Texture2D
	RegisterUnityClass<Texture2D>("Core");
	//17. Cubemap
	RegisterUnityClass<Cubemap>("Core");
	//18. Texture3D
	RegisterUnityClass<Texture3D>("Core");
	//19. Texture2DArray
	RegisterUnityClass<Texture2DArray>("Core");
	//20. CubemapArray
	RegisterUnityClass<CubemapArray>("Core");
	//21. RenderTexture
	RegisterUnityClass<RenderTexture>("Core");
	//22. GUIElement
	RegisterUnityClass<GUIElement>("Core");
	//23. GUILayer
	RegisterUnityClass<GUILayer>("Core");
	//24. GameObject
	RegisterUnityClass<GameObject>("Core");
	//25. MonoBehaviour
	RegisterUnityClass<MonoBehaviour>("Core");
	//26. TextAsset
	RegisterUnityClass<TextAsset>("Core");
	//27. ComputeShader
	RegisterUnityClass<ComputeShader>("Core");
	//28. LowerResBlitTexture
	RegisterUnityClass<LowerResBlitTexture>("Core");
	//29. PreloadData
	RegisterUnityClass<PreloadData>("Core");
	//30. UI::RectTransform
	RegisterUnityClass<UI::RectTransform>("Core");
	//31. Transform
	RegisterUnityClass<Transform>("Core");
	//32. SpriteRenderer
	RegisterUnityClass<SpriteRenderer>("Core");
	//33. Sprite
	RegisterUnityClass<Sprite>("Core");
	//34. SpriteAtlas
	RegisterUnityClass<SpriteAtlas>("Core");
	//35. Animator
	RegisterUnityClass<Animator>("Animation");
	//36. AnimatorOverrideController
	RegisterUnityClass<AnimatorOverrideController>("Animation");
	//37. RuntimeAnimatorController
	RegisterUnityClass<RuntimeAnimatorController>("Animation");
	//38. AudioClip
	RegisterUnityClass<AudioClip>("Audio");
	//39. SampleClip
	RegisterUnityClass<SampleClip>("Audio");
	//40. AudioSource
	RegisterUnityClass<AudioSource>("Audio");
	//41. AudioBehaviour
	RegisterUnityClass<AudioBehaviour>("Audio");
	//42. Rigidbody2D
	RegisterUnityClass<Rigidbody2D>("Physics2D");
	//43. TextRendering::Font
	RegisterUnityClass<TextRendering::Font>("TextRendering");
	//44. UI::Canvas
	RegisterUnityClass<UI::Canvas>("UI");
	//45. UI::CanvasGroup
	RegisterUnityClass<UI::CanvasGroup>("UI");
	//46. UI::CanvasRenderer
	RegisterUnityClass<UI::CanvasRenderer>("UI");
	//47. Collider2D
	RegisterUnityClass<Collider2D>("Physics2D");
	//48. MonoScript
	RegisterUnityClass<MonoScript>("Core");
	//49. UnityConnectSettings
	RegisterUnityClass<UnityConnectSettings>("UnityConnect");
	//50. AudioManager
	RegisterUnityClass<AudioManager>("Audio");
	//51. PlayerSettings
	RegisterUnityClass<PlayerSettings>("Core");
	//52. TimeManager
	RegisterUnityClass<TimeManager>("Core");
	//53. InputManager
	RegisterUnityClass<InputManager>("Core");
	//54. TagManager
	RegisterUnityClass<TagManager>("Core");
	//55. MonoManager
	RegisterUnityClass<MonoManager>("Core");
	//56. GraphicsSettings
	RegisterUnityClass<GraphicsSettings>("Core");
	//57. DelayedCallManager
	RegisterUnityClass<DelayedCallManager>("Core");
	//58. BuildSettings
	RegisterUnityClass<BuildSettings>("Core");
	//59. RuntimeInitializeOnLoadManager
	RegisterUnityClass<RuntimeInitializeOnLoadManager>("Core");
	//60. ResourceManager
	RegisterUnityClass<ResourceManager>("Core");
	//61. ScriptMapper
	RegisterUnityClass<ScriptMapper>("Core");
	//62. Physics2DSettings
	RegisterUnityClass<Physics2DSettings>("Physics2D");
	//63. AudioListener
	RegisterUnityClass<AudioListener>("Audio");
	//64. LightmapSettings
	RegisterUnityClass<LightmapSettings>("Core");
	//65. LevelGameManager
	RegisterUnityClass<LevelGameManager>("Core");
	//66. RenderSettings
	RegisterUnityClass<RenderSettings>("Core");
	//67. AnimationClip
	RegisterUnityClass<AnimationClip>("Animation");
	//68. Motion
	RegisterUnityClass<Motion>("Animation");
	//69. BoxCollider2D
	RegisterUnityClass<BoxCollider2D>("Physics2D");
	//70. AnimatorController
	RegisterUnityClass<AnimatorController>("Animation");
	//71. CircleCollider2D
	RegisterUnityClass<CircleCollider2D>("Physics2D");
	//72. EdgeCollider2D
	RegisterUnityClass<EdgeCollider2D>("Physics2D");

}
