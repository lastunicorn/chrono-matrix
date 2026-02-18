# Chrono Matrix

## Overview

A WPF application that displays a digital clock "drawn" using 96 analog clock.

![Chrono Matrix](/doc/main/chrono-matrix.png)

## More Details

Each digit is created with 24 analog clocks whose hands are carefully aligned to "draw" the desired digit.

For each clock this `AnalogClock` control is used:

- https://github.com/lastunicorn/clock-wpf

... with a custom template that displays only the clock's hands:

![Clock Template](/doc/main/clock-template.png)
