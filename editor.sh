#!/bin/bash

cp -u ./pandemonium_engine/bin/pandemonium.x11.opt.tools.64.mono ./pandemonium_engine/bin/run.pandemonium.x11.opt.tools.64.mono

export LD_LIBRARY_PATH=`pwd`/pandemonium_engine/bin/
./pandemonium_engine/bin/run.pandemonium.x11.opt.tools.64.mono -v 
