
from openai import OpenAI
import os



key = "nenenenenemeinkeywirdnichtgescammt"
OpenAI.my_api_key = key



#client = OpenAI(
    # This is the default and can be omitted
#    api_key=os.environ.get("auch nicht im kommenta >:["),
#)

chat_completion = OpenAI.chat.completions.create(
    messages=[
        {
            "role": "user",
            "content": "Say this is a test",
        }
    ],
    model="gpt-3.5-turbo",
)



def get_response(a):
    return str(a+"World")






