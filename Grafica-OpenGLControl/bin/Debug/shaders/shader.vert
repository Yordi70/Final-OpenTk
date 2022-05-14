#version 330 core

// the position variable has attribute position 0
layout(location = 0) in vec3 aPosition; 
uniform mat4 move;
uniform mat4 transform;

void main(void)
{
	
    gl_Position = vec4(aPosition, 1.0) * move *transform;
}