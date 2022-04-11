using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace MyForms
{
    public partial class DirectXWindow : Form
    {
        private Device _device;

        private VertexBuffer vb = null;

        CustomVertex.PositionColored[] verts = null;

        float angle = 0.0f;


        public DirectXWindow()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true);

            InitializeComponent();

            InitializeMapping();
        }

        private void InitializeMapping()
        {
            PresentParameters presentParameters = new();
            presentParameters.Windowed = false;
            presentParameters.SwapEffect = SwapEffect.Discard;

            _device = new Device(0, DeviceType.Hardware, this, CreateFlags.HardwareVertexProcessing, presentParameters);
            vb = new VertexBuffer(typeof(CustomVertex.PositionColored), 3, _device, Usage.WriteOnly, CustomVertex.PositionColored.Format, Pool.Default);
            vb.Created += new EventHandler(this.OnVertexBufferCreate);
            OnVertexBufferCreate(vb, null);

            vb.SetData(verts, 0, LockFlags.None);
        }

        private void OnVertexBufferCreate(object sender, EventArgs e)
        {
            VertexBuffer butter = (VertexBuffer)sender;

            verts = new CustomVertex.PositionColored[3];

            verts[0].Position = new Vector3(0, 1, 1);
            verts[0].Color = Color.Green.ToArgb();

            verts[1].Position = new Vector3(-1, -1, 1);
            verts[1].Color = Color.Blue.ToArgb();

            verts[2].Position = new Vector3(1, -1, 1);
            verts[2].Color = Color.Red.ToArgb();

            butter.SetData(verts, 0, LockFlags.None);

        }


        private void SetupCamera()
        {
            _device.Transform.Projection = Matrix.OrthoLH(Width, Height, 0f, 0f);
            _device.Transform.View = Matrix.OrthoLH(Width, Height, 0f, 0f);
        }

        private void OpenGLEngine_Paint(object sender, PaintEventArgs e)
        {
            _device.Clear(ClearFlags.Target, Color.Black, 0, 1);

            SetupCamera();

            _device.BeginScene();

            _device.VertexFormat = CustomVertex.PositionColored.Format;
            _device.VertexFormat = CustomVertex.PositionColored.Format;
            _device.SetStreamSource(0, vb, 0);
            _device.DrawPrimitives(PrimitiveType.TriangleList, 0, 1);



            _device.EndScene();
            _device.Present();

            Invalidate();
        }
    }
}