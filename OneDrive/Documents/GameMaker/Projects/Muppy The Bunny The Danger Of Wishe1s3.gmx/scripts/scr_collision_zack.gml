///scr_collision_zack()
var vxNew, vyNew;

// Handle sub-pixel movement
xVelSub += xVel;
yVelSub += yVel;
vxNew = round(xVelSub);
vyNew = round(yVelSub);
xVelSub -= vxNew;
yVelSub -= vyNew;

// Vertical
repeat(abs(vyNew)) {
    if (!place_meeting(x, y + sign(vyNew), obj_collision_par))
        y += sign(vyNew); 
    else {
        yVel = 0;
        break;
    }
}

// Horizontal
repeat(abs(vxNew)) {

    // Move up slope
    if (place_meeting(x + sign(vxNew), y, obj_collision_par) && !place_meeting(x + sign(vxNew), y - 1, obj_collision_par))
        --y;
    
    // Move down slope
    if (!place_meeting(x + sign(vxNew), y, obj_collision_par) && !place_meeting(x + sign(vxNew), y + 1, obj_collision_par) && place_meeting(x + sign(vxNew), y + 2, obj_collision_par))
        ++y; 

    if (!place_meeting(x + sign(vxNew), y, obj_collision_par))
        x += sign(vxNew); 
    else {
        xVel = 0;
        break;
    }
}
