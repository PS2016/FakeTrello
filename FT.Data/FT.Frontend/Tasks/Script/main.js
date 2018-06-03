$(() => {
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
        State: "Fire"
    },
    {
        Id: "124",
        Title: "MyTitle2",
        Description: "Mегаважное задание",
        DateCreated: "22/01/2018",
        Priority: "High",
        State: "Fire"
    }
];

function ShowTask(id) {
    var task = tasks.find((x) => { x.Id === id });
    CreateTask(task);
}

function CreateTaskPreview(task, priority, descpreview) {
    return `<div class="panel panel-${priority}" onclick="ShowTask(${task.Id})">
                <div class="panel-heading task-heading">${task.Title}</div>
                <div class="panel-body task-body">${descpreview}</div>
            </div>`
}