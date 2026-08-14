#version 330 core
out vec4 FragColor;

in vec3 vertexColor; // the input variable from the vertex shader (same name and same type)  
in vec2 TexCoord;

uniform sampler2D ourTexture;
uniform vec4 backgroundColor;

void main()
{
    vec4 texColor = texture(ourTexture, TexCoord);

    if (vertexColor == vec3(1.0))
    {
        FragColor = texColor;
    }
    else
    {
        vec3 finalRGB = texColor.rgb * vertexColor;

        FragColor = vec4(
            mix(backgroundColor.rgb, finalRGB, texColor.a),
            1.0
        );
    }
}