// This is a usefull script by Matt Thorson that works as a FOR statement.
// Is very usefull to apply in acceleration or breaking movement effects!

// Approach(start, end, shift);
if (argument0 < argument1)
    return min(argument0 + argument2, argument1); 
else
    return max(argument0 - argument2, argument1);
