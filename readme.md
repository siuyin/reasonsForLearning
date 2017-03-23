# Reasons for Learning
1. Engage
1. Enrich

## Engage
Answer "Why should I learn X?"

Eg. You should learn Set theory because that is the way
modern databases work. It is used by businesses and
industries to answer questions like:

    "What proportion of this bank's customers spent more
    than $1000 last month and did not fully pay up their
    bill?"

This could be implemented with a chatbot. See:
[Q and A maker](https://qnamaker.ai) . You will need
a Microsoft account.

The response text could be put through text-to-speech.
Bluemix Watson as well as Microsoft offer such services.

Consider using a stemming library like:
[snowball](https://github.com/kljensen/snowball).


## Enrich
Provide a lesson which caters for auditory, visual and
kinesthetic learners.

Eg. Use the TI cc2650 IOT multi-sensor to demonstrate usage
of the small angle formula: angle in radians * baseline length.

We will need to track the student, hence some form of
login / authentication will be required.

### Ideas for sensor device
1. Most phones have accelerometers.
1. Some have gyroscopes.
1. Others have proximity sensors.

The accelerometer can be used to determine angles / orientation.
The gyroscope tells you the rotation rate. Rotation rate
should be close to zero before measuring the angle.should

If available the proximity sensor can be used as a touchless
trigger to mark a data capture.

ioTool from play store has a gateway and many extensions.

## UI ideas.
* here is a link for a tabbed-page layout. https://codepen.io/renatorib/pen/rlpfj

## Tools
1. webdemo.balsamiq.com -- save mockups as .json
1. storyboardthat.com -- limited free storyboarding.
1. oauth2 (facebook, google etc) -- https://github.com/golang/oauth2
