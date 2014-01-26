// This plugin will automatically rotate the globe around its vertical
// axis a configured number of degrees every second.
function autorotate(degPerSec) {
    // Planetary.js plugins are functions that take a `planet` instance
    // as an argument...
    return function(planet) {
        var lastTick = null;
        var paused = false;
        planet.plugins.autorotate = {
            pause:  function() { paused = true;  },
            resume: function() { paused = false; }
        };
        // ...and configure hooks into certain pieces of its lifecycle.
        planet.onDraw(function() {
            if (paused || !lastTick) {
                lastTick = new Date();
            } else {
                var now = new Date();
                var delta = now - lastTick;
                // This plugin uses the built-in projection (provided by D3)
                // to rotate the globe each time we draw it.
                var rotation = planet.projection.rotate();
                rotation[0] += degPerSec * delta / 1000;
                if (rotation[0] >= 180) rotation[0] -= 360;
                planet.projection.rotate(rotation);
                lastTick = now;
            }
        });
    };
};

// This plugin takes lake data from the special
// TopoJSON we're loading and draws them on the map.
function lakes(options) {
    options = options || {};
    var lakes = null;

    return function(planet) {
        planet.onInit(function() {
            // We can access the data loaded from the TopoJSON plugin
            // on its namespace on `planet.plugins`. We're loading a custom
            // TopoJSON file with an object called &quot;ne_110m_lakes&quot;.
            var world = planet.plugins.topojson.world;
            lakes = topojson.feature(world, world.objects.ne_110m_lakes);
        });

        planet.onDraw(function() {
            planet.withSavedContext(function(context) {
                context.beginPath();
                planet.path.context(context)(lakes);
                context.fillStyle = options.fill || 'black';
                context.fill();
            });
        });
    };
};