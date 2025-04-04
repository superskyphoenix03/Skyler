// Horizontal movement
if (keyboard_check(vk_left)) {
    hspd = -move_speed;
} else if (keyboard_check(vk_right)) {
    hspd = move_speed;
} else {
    hspd = 0;
}

// Apply gravity
vspd += gravity;

// Jumping
if (place_meeting(x, y + 1, obj_solid_p) || place_meeting(x, y + 1, obj_solid_slope)) {
    if (keyboard_check_pressed(vk_space)) {
        vspd = jump_speed;
    }
}

// Horizontal collision
if (place_meeting(x + hspd, y, obj_solid_p) || place_meeting(x + hspd, y, obj_solid_slope)) {
    while (!place_meeting(x + sign(hspd), y, obj_solid_p) && !place_meeting(x + sign(hspd), y, obj_solid_slope)) {
        x += sign(hspd);
    }
    hspd = 0;
}

x += hspd;

// Vertical collision
if (place_meeting(x, y + vspd, obj_solid_p) || place_meeting(x, y + vspd, obj_solid_slope)) {
    while (!place_meeting(x, y + sign(vspd), obj_solid_p) && !place_meeting(x, y + sign(vspd), obj_solid_slope)) {
        y += sign(vspd);
    }
    vspd = 0;
}

y += vspd;

