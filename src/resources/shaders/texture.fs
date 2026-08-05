#version 330 core
out vec4 FragColor;

in vec3 vertexColor; // the input variable from the vertex shader (same name and same type)  
in vec2 TexCoord;

uniform sampler2D ourTexture;
uniform vec4 uTint;
uniform float uTintStrength;

void main()
{
    vec4 texColor = texture(ourTexture, TexCoord);
    vec4 tinted = texColor * uTint;

    FragColor = mix(texColor, tinted, uTintStrength);
}