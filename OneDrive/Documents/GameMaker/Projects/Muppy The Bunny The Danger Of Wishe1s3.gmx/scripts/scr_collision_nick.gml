///scr_collision_nick()
var vxNew, vyNew;

/***************************************************
  Horizontal Movement
 ***************************************************/
if xVel != 0
{
    xVelSub    += xVel;
    vxNew       = round(xVelSub);
    xVelSub    -= vxNew;
    var xdir    = sign(vxNew)

    // Horizontal
    repeat(abs(vxNew))
    {
        // In case of horizontal collision
        if collision_rectangle(bbox_left + xdir, bbox_top, bbox_right + xdir, bbox_bottom, obj_collision_par, true, true)
        {
            // If it's a slope up
            if !collision_rectangle(bbox_left + xdir, bbox_top - 1, bbox_right + xdir, bbox_bottom - 1, obj_collision_par, true, true)
            {
                --y         // Move Up
                x += xdir   // Move Ahead
            }
            // If it's not a slope
            else
            {
                xVel = 0    // Stop completely
                break       // Stop repeating. We're still.
            }
        }
        // If there is no obstacle ahead
        else
        {
            // In case it's a slope down
            if (yVel >= 0) && !collision_rectangle(bbox_left + xdir, bbox_top + 1, bbox_right + xdir, bbox_bottom + 1, obj_collision_par, true, true) && collision_rectangle(bbox_left + xdir, bbox_top + 2, bbox_right + xdir, bbox_bottom + 2, obj_collision_par, true, true)
                ++y         // Move Down
            
            // Move ahead then
            x += xdir
        }
    }
}

/***************************************************
  Vertical Movement
 ***************************************************/
if yVel != 0
{
    yVelSub    += yVel;
    vyNew       = round(yVelSub);
    yVelSub    -= vyNew;
    var ydir    = sign(vyNew)
    
    // Check our direction (up or down)
    if ydir == 0
        var coll = noone
    else if ydir == 1
        var coll = collision_rectangle(bbox_left, bbox_top, bbox_right, bbox_bottom + vyNew, obj_collision_par, true, false)
    else if ydir == -1
        var coll = collision_rectangle(bbox_left, bbox_top + vyNew, bbox_right, bbox_bottom, obj_collision_par, true, false)
    
    // If there's a collision, move to contact
    if coll
    {
        while (!collision_rectangle(bbox_left, bbox_top + ydir, bbox_right, bbox_bottom + ydir, obj_collision_par, true, false))
        {
            y += ydir
        }
        
        // Once in contact, set the speeds to 0
        vyNew   = 0
        yVel    = 0
    }
    else // If no contact, move freely
        y += vyNew
}
