$(() => {
   /* $.get("localhost:33033", function (data) {
        alert("Load was performed.");
    });*/
    $(".panel-group").html("");
    for (var task of tasks) {
        let priority = "default";
        if (task.Priority === "Low") priority = "success";
        else if (task.Priority === "Medium") priority = "warning";
        else if (task.Priority === "High") priority = "danger";
        let descprev = task.Description.substring(0, 12);
        if (descprev !== task.Description) descprev += "...";
        $(".panel-group").append(CreateTaskPreview(task, priority, descprev));
    }

});

var tasks = [
    {
        Id: "123",
        Title: "MyTitle",
        Description: "Супермегаважное задание",
        DateCreated:  "22/01/2018",
        Priority: "Low",
        Type: "OK",
        State: "Fire"
    },
    {
        Id: "124",
        Title: "MyTitle2",
        Description: "Mегаважное задание",
        DateCreated: "22/01/2018",
        Priority: "High",
        Type: "OK",
        State: "Fire"
    }
];


function CreateTaskPreview(task, priority, descpreview) {
    return `<div class="panel panel-${priority}" data-toggle="modal" style="margin-top: 5px" data-target="#task${task.Id}">
        <div class="panel-heading task-heading">${task.Title}</div>
        <div class="panel-body task-body">${descpreview}</div>

        </div>
    </div>
<div class="modal fade" id="task${task.Id}" role="dialog">
            <div class="modal-dialog">
      <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">${task.Title}</h4>
                    </div>
                    <div class="modal-body">
                        <p>Description: ${task.Description}</p>
                        <p>Date: ${task.DateCreated}</p>
                        <p>Type: ${task.Type}</p>
                        <p>State: ${task.State}</p>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>`;
}