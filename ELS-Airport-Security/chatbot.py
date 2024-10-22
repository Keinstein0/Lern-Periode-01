import time
""" 
#from openai import OpenAI
"""
# Theoretical ChatGPT Processing
# Not working because no money

def get_response(item):
    rand = len(item) % 2   
    print(rand)         #
    if rand == 1:       # Code as a Replacement for ChatGPT response :<
        return (True)   # 
    else:               #
        return (False)  #

    # ChatGPT Response (if it would work...)
    """
    client = OpenAI(api_key=key) 


    completion = client.chat.completions.create(
        model="gpt-3.5-turbo",
        messages=[
            {"role": "system", "content": "You are a helpful assistant."},
            {
                "role": "user",
                "content": "Hey ChatGPT, you are the bot of an airport security check tool. Your task is to determine if an item (later provided) is safe to bring on an airplane. You determine if its safe, if so, you respond with True, else you respond False. Nothing else! Here the item:"+"item"
            }
        ]
    )

    return bool(completion.choices[0].message)
    """






