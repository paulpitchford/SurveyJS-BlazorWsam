// Initializes and renders the SurveyJS form, accepting a .NET object reference for callbacks
window.initSurvey = function (dotNetHelper) {
    console.log("initSurvey function called");

    // Define the survey JSON configuration
    var surveyJson = {
        title: "Customer Satisfaction Survey",
        showProgressBar: "bottom",
        "pages":
            [
                {
                    "name": "qualifications_page",
                    "title": "Your Qualifications",
                    "elements": [
                        {
                            "type": "paneldynamic",
                            "name": "qsuestion1",
                            "title": "Place of Study",
                            "templateElements": [
                                {
                                    "type": "text",
                                    "name": "name of school",
                                    "title": "Name of School",
                                    "isRequired": true
                                },
                                {
                                    "type": "text",
                                    "name": "start date",
                                    "title": "Start Date",
                                    "isRequired": true,
                                    "inputType": "date"
                                },
                                {
                                    "type": "text",
                                    "name": "end date",
                                    "title": "End Date",
                                    "isRequired": true,
                                    "inputType": "date"
                                },
                                {
                                    "type": "paneldynamic",
                                    "name": "Qualifcations",
                                    "title": "Enter your qualifications",
                                    "isRequired": true,
                                    "templateElements": [
                                        {
                                            "type": "text",
                                            "name": "subject",
                                            "title": "Subject"
                                        },
                                        {
                                            "type": "text",
                                            "name": "grade",
                                            "title": "Grade",
                                            "isRequired": true
                                        }
                                    ],
                                    "panelAddText": "Add new qualifcation",
                                    "panelRemoveText": "Remove qualifction"
                                }
                            ],
                            "panelAddText": "Add new place of study",
                            "panelRemoveText": "Remove place of study"
                        }
                    ]
                }
            ]
    };

    console.log("Survey JSON:", JSON.stringify(surveyJson, null, 2));
    console.log("Creating survey model");
    var survey = new Survey.Model(surveyJson);
    console.log("Survey model created:", survey);

    // Event handler for when the survey is completed
    survey.onComplete.add(function (sender) {
        // Serialize the survey results and the survey structure to JSON strings
        var results = {
            surveyData: JSON.stringify(sender.data),
            surveyStructure: JSON.stringify(surveyJson)
        };
        console.log("Survey completed, sending results");

        // Send both the data and the structure to the .NET method
        dotNetHelper.invokeMethodAsync('ProcessSurveyResults', results);
    });

    // Get a reference to the survey container element
    var surveyContainer = document.getElementById('surveyContainer');
    console.log("Survey container:", surveyContainer);

    // Check if the element exists
    if (!surveyContainer) {
        console.error("Survey container element not found");
        return;
    }

    console.log("Rendering survey");
    survey.render(surveyContainer);
    console.log("Survey rendered");
};
