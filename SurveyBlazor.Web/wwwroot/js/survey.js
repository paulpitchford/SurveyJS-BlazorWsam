// Initializes and renders the SurveyJS form, accepting a .NET object reference for callbacks
window.initSurvey = function(dotNetHelper) {
    console.log("initSurvey function called");
    
    // Define the survey JSON configuration
    var surveyJson = {
        title: "Customer Satisfaction Survey",
        showProgressBar: "bottom",
        pages: [
            {
                elements: [
                    {
                        name: "satisfaction",
                        type: "rating",
                        title: "How satisfied are you with our product?",
                        isRequired: true,
                        minRateDescription: "Not Satisfied",
                        maxRateDescription: "Completely Satisfied"
                    },
                    {
                        name: "feedback",
                        type: "comment",
                        title: "What would make you more satisfied with our product?"
                    }
                ]
            }
        ]
    };

    console.log("Creating survey model");
    var survey = new Survey.Model(surveyJson);

    // Event handler for when the survey is completed
    survey.onComplete.add(function(sender) {
        // Serialize the survey results to a JSON string
        var results = JSON.stringify(sender.data);
        console.log("Survey completed, sending results");
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
